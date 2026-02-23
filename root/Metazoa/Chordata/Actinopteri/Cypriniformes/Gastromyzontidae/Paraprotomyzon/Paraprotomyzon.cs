using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Paraprotomyzon;

/// <summary>
/// Abstract class for Paraprotomyzon (genus).
/// NCBI TaxId: 241468
/// </summary>
public abstract class Paraprotomyzon : Gastromyzontidae, IParaprotomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraprotomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241468;

    /// <inheritdoc />
    public virtual string GenusName => "Paraprotomyzon";

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
