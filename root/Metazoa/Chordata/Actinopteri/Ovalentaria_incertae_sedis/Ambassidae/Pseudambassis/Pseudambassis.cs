using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Pseudambassis;

/// <summary>
/// Abstract class for Pseudambassis (genus).
/// NCBI TaxId: 983946
/// </summary>
public abstract class Pseudambassis : Ambassidae, IPseudambassis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudambassis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 983946;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudambassis";

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
