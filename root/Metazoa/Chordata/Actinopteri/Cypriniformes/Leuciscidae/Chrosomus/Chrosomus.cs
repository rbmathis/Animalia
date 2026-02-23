using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Chrosomus;

/// <summary>
/// Abstract class for Chrosomus (genus).
/// NCBI TaxId: 1046118
/// </summary>
public abstract class Chrosomus : Leuciscidae, IChrosomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrosomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1046118;

    /// <inheritdoc />
    public virtual string GenusName => "Chrosomus";

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
