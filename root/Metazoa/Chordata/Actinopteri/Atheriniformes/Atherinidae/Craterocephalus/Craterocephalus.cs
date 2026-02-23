using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Craterocephalus;

/// <summary>
/// Abstract class for Craterocephalus (genus).
/// NCBI TaxId: 69133
/// </summary>
public abstract class Craterocephalus : Atherinidae, ICraterocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Craterocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69133;

    /// <inheritdoc />
    public virtual string GenusName => "Craterocephalus";

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
