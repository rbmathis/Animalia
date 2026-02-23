using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Chatrabus;

/// <summary>
/// Abstract class for Chatrabus (genus).
/// NCBI TaxId: 990952
/// </summary>
public abstract class Chatrabus : Batrachoididae, IChatrabus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chatrabus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990952;

    /// <inheritdoc />
    public virtual string GenusName => "Chatrabus";

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
