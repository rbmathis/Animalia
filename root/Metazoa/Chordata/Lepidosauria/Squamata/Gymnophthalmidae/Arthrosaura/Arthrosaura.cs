using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Arthrosaura;

/// <summary>
/// Abstract class for Arthrosaura (genus).
/// NCBI TaxId: 174737
/// </summary>
public abstract class Arthrosaura : Gymnophthalmidae, IArthrosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arthrosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174737;

    /// <inheritdoc />
    public virtual string GenusName => "Arthrosaura";

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
