using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Haploblepharus;

/// <summary>
/// Abstract class for Haploblepharus (genus).
/// NCBI TaxId: 1003956
/// </summary>
public abstract class Haploblepharus : Scyliorhinidae, IHaploblepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haploblepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003956;

    /// <inheritdoc />
    public virtual string GenusName => "Haploblepharus";

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
