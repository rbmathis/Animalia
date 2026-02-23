using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Hapalogenyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Hapalogenyidae.Hapalogenys;

/// <summary>
/// Abstract class for Hapalogenys (genus).
/// NCBI TaxId: 360504
/// </summary>
public abstract class Hapalogenys : Hapalogenyidae, IHapalogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hapalogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360504;

    /// <inheritdoc />
    public virtual string GenusName => "Hapalogenys";

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
