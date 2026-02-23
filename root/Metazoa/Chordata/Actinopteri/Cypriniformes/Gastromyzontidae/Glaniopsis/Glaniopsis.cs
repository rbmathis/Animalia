using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Glaniopsis;

/// <summary>
/// Abstract class for Glaniopsis (genus).
/// NCBI TaxId: 1367693
/// </summary>
public abstract class Glaniopsis : Gastromyzontidae, IGlaniopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaniopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1367693;

    /// <inheritdoc />
    public virtual string GenusName => "Glaniopsis";

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
