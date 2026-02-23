using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Ventichthys;

/// <summary>
/// Abstract class for Ventichthys (genus).
/// NCBI TaxId: 1428775
/// </summary>
public abstract class Ventichthys : Ophidiidae, IVentichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ventichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1428775;

    /// <inheritdoc />
    public virtual string GenusName => "Ventichthys";

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
