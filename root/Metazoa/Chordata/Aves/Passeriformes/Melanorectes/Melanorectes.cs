using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanorectes;

/// <summary>
/// Abstract class for Melanorectes (genus).
/// NCBI TaxId: 2497054
/// </summary>
public abstract class Melanorectes : Passeriformes, IMelanorectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanorectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2497054;

    /// <inheritdoc />
    public virtual string GenusName => "Melanorectes";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
