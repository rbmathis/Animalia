using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Derichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Derichthyidae.Derichthys;

/// <summary>
/// Abstract class for Derichthys (genus).
/// NCBI TaxId: 391191
/// </summary>
public abstract class Derichthys : Derichthyidae, IDerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Derichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391191;

    /// <inheritdoc />
    public virtual string GenusName => "Derichthys";

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
