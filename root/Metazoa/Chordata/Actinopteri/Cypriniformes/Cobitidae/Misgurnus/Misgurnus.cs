using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Misgurnus;

/// <summary>
/// Abstract class for Misgurnus (genus).
/// NCBI TaxId: 7983
/// </summary>
public abstract class Misgurnus : Cobitidae, IMisgurnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Misgurnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7983;

    /// <inheritdoc />
    public virtual string GenusName => "Misgurnus";

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
