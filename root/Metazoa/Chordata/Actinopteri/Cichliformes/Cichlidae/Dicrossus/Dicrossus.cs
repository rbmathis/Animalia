using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Dicrossus;

/// <summary>
/// Abstract class for Dicrossus (genus).
/// NCBI TaxId: 284700
/// </summary>
public abstract class Dicrossus : Cichlidae, IDicrossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicrossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 284700;

    /// <inheritdoc />
    public virtual string GenusName => "Dicrossus";

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
