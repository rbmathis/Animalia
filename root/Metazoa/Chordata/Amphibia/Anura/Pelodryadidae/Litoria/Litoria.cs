using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Litoria;

/// <summary>
/// Abstract class for Litoria (genus).
/// NCBI TaxId: 8370
/// </summary>
public abstract class Litoria : Pelodryadidae, ILitoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Litoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8370;

    /// <inheritdoc />
    public virtual string GenusName => "Litoria";

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
