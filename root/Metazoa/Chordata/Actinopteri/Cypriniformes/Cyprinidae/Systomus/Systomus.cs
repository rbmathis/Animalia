using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Systomus;

/// <summary>
/// Abstract class for Systomus (genus).
/// NCBI TaxId: 1162207
/// </summary>
public abstract class Systomus : Cyprinidae, ISystomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Systomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1162207;

    /// <inheritdoc />
    public virtual string GenusName => "Systomus";

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
