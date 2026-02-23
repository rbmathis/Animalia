using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae.Triportheus;

/// <summary>
/// Abstract class for Triportheus (genus).
/// NCBI TaxId: 42553
/// </summary>
public abstract class Triportheus : Triportheidae, ITriportheus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triportheus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42553;

    /// <inheritdoc />
    public virtual string GenusName => "Triportheus";

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
