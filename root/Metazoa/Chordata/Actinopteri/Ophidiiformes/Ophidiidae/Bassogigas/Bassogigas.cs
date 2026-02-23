using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Bassogigas;

/// <summary>
/// Abstract class for Bassogigas (genus).
/// NCBI TaxId: 1311533
/// </summary>
public abstract class Bassogigas : Ophidiidae, IBassogigas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bassogigas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311533;

    /// <inheritdoc />
    public virtual string GenusName => "Bassogigas";

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
