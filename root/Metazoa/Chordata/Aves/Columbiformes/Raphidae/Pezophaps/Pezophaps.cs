using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Raphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Raphidae.Pezophaps;

/// <summary>
/// Abstract class for Pezophaps (genus).
/// NCBI TaxId: 187132
/// </summary>
public abstract class Pezophaps : Raphidae, IPezophaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pezophaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187132;

    /// <inheritdoc />
    public virtual string GenusName => "Pezophaps";

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
