using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Tropiocolotes;

/// <summary>
/// Abstract class for Tropiocolotes (genus).
/// NCBI TaxId: 401550
/// </summary>
public abstract class Tropiocolotes : Gekkonidae, ITropiocolotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropiocolotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 401550;

    /// <inheritdoc />
    public virtual string GenusName => "Tropiocolotes";

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
