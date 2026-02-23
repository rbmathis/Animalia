using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Otocryptis;

/// <summary>
/// Abstract class for Otocryptis (genus).
/// NCBI TaxId: 118219
/// </summary>
public abstract class Otocryptis : Agamidae, IOtocryptis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otocryptis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118219;

    /// <inheritdoc />
    public virtual string GenusName => "Otocryptis";

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
