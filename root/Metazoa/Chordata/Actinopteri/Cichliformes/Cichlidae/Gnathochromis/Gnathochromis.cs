using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Gnathochromis;

/// <summary>
/// Abstract class for Gnathochromis (genus).
/// NCBI TaxId: 32497
/// </summary>
public abstract class Gnathochromis : Cichlidae, IGnathochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32497;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathochromis";

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
