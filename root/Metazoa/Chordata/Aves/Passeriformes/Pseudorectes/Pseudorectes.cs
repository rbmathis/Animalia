using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pseudorectes;

/// <summary>
/// Abstract class for Pseudorectes (genus).
/// NCBI TaxId: 1743253
/// </summary>
public abstract class Pseudorectes : Passeriformes, IPseudorectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudorectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743253;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudorectes";

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
