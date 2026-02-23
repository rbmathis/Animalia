using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Pteroplatytrygon;

/// <summary>
/// Abstract class for Pteroplatytrygon (genus).
/// NCBI TaxId: 651722
/// </summary>
public abstract class Pteroplatytrygon : Dasyatidae, IPteroplatytrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteroplatytrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651722;

    /// <inheritdoc />
    public virtual string GenusName => "Pteroplatytrygon";

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
