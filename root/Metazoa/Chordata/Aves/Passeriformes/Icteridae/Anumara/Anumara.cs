using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Anumara;

/// <summary>
/// Abstract class for Anumara (genus).
/// NCBI TaxId: 3150797
/// </summary>
public abstract class Anumara : Icteridae, IAnumara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anumara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150797;

    /// <inheritdoc />
    public virtual string GenusName => "Anumara";

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
