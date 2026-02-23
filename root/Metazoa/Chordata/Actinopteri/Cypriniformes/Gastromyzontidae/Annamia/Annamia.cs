using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Annamia;

/// <summary>
/// Abstract class for Annamia (genus).
/// NCBI TaxId: 2759046
/// </summary>
public abstract class Annamia : Gastromyzontidae, IAnnamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Annamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2759046;

    /// <inheritdoc />
    public virtual string GenusName => "Annamia";

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
