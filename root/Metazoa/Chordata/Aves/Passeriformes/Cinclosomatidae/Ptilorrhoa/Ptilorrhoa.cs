using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Ptilorrhoa;

/// <summary>
/// Abstract class for Ptilorrhoa (genus).
/// NCBI TaxId: 254656
/// </summary>
public abstract class Ptilorrhoa : Cinclosomatidae, IPtilorrhoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilorrhoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254656;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilorrhoa";

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
