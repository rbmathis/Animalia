using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cleithracara;

/// <summary>
/// Abstract class for Cleithracara (genus).
/// NCBI TaxId: 172536
/// </summary>
public abstract class Cleithracara : Cichlidae, ICleithracara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cleithracara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172536;

    /// <inheritdoc />
    public virtual string GenusName => "Cleithracara";

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
