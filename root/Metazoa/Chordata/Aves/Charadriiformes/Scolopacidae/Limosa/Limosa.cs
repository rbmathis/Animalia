using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Limosa;

/// <summary>
/// Abstract class for Limosa (genus).
/// NCBI TaxId: 161679
/// </summary>
public abstract class Limosa : Scolopacidae, ILimosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161679;

    /// <inheritdoc />
    public virtual string GenusName => "Limosa";

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
