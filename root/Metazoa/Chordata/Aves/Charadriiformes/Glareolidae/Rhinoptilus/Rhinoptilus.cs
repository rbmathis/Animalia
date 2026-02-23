using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae.Rhinoptilus;

/// <summary>
/// Abstract class for Rhinoptilus (genus).
/// NCBI TaxId: 240208
/// </summary>
public abstract class Rhinoptilus : Glareolidae, IRhinoptilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoptilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240208;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoptilus";

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
