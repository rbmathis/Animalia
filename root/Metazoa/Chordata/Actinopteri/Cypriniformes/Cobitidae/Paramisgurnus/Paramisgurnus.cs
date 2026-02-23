using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Paramisgurnus;

/// <summary>
/// Abstract class for Paramisgurnus (genus).
/// NCBI TaxId: 90734
/// </summary>
public abstract class Paramisgurnus : Cobitidae, IParamisgurnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramisgurnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90734;

    /// <inheritdoc />
    public virtual string GenusName => "Paramisgurnus";

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
