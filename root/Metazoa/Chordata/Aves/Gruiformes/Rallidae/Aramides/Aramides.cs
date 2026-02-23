using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Aramides;

/// <summary>
/// Abstract class for Aramides (genus).
/// NCBI TaxId: 54569
/// </summary>
public abstract class Aramides : Rallidae, IAramides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aramides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54569;

    /// <inheritdoc />
    public virtual string GenusName => "Aramides";

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
