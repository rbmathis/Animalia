using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae.Lignobrycon;

/// <summary>
/// Abstract class for Lignobrycon (genus).
/// NCBI TaxId: 930349
/// </summary>
public abstract class Lignobrycon : Triportheidae, ILignobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lignobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930349;

    /// <inheritdoc />
    public virtual string GenusName => "Lignobrycon";

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
