using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gnathopogon;

/// <summary>
/// Abstract class for Gnathopogon (genus).
/// NCBI TaxId: 328527
/// </summary>
public abstract class Gnathopogon : Gobionidae, IGnathopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328527;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathopogon";

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
