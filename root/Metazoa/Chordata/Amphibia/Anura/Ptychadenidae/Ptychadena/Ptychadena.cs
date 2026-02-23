using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena;

/// <summary>
/// Abstract class for Ptychadena (genus).
/// NCBI TaxId: 88030
/// </summary>
public abstract class Ptychadena : Ptychadenidae, IPtychadena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptychadena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88030;

    /// <inheritdoc />
    public virtual string GenusName => "Ptychadena";

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
