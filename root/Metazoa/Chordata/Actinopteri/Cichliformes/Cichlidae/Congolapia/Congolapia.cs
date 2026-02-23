using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Congolapia;

/// <summary>
/// Abstract class for Congolapia (genus).
/// NCBI TaxId: 1263295
/// </summary>
public abstract class Congolapia : Cichlidae, ICongolapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congolapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1263295;

    /// <inheritdoc />
    public virtual string GenusName => "Congolapia";

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
