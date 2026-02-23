using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Colleeneremia;

/// <summary>
/// Abstract class for Colleeneremia (genus).
/// NCBI TaxId: 3680988
/// </summary>
public abstract class Colleeneremia : Pelodryadidae, IColleeneremia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colleeneremia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680988;

    /// <inheritdoc />
    public virtual string GenusName => "Colleeneremia";

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
