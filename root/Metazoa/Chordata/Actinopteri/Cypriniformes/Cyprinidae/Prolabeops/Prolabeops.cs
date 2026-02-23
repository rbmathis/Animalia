using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Prolabeops;

/// <summary>
/// Abstract class for Prolabeops (genus).
/// NCBI TaxId: 2978363
/// </summary>
public abstract class Prolabeops : Cyprinidae, IProlabeops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prolabeops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2978363;

    /// <inheritdoc />
    public virtual string GenusName => "Prolabeops";

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
