using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Aceros;

/// <summary>
/// Abstract class for Aceros (genus).
/// NCBI TaxId: 175823
/// </summary>
public abstract class Aceros : Bucerotidae, IAceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175823;

    /// <inheritdoc />
    public virtual string GenusName => "Aceros";

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
