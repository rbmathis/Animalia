using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae.Platyrhinoidis;

/// <summary>
/// Abstract class for Platyrhinoidis (genus).
/// NCBI TaxId: 117850
/// </summary>
public abstract class Platyrhinoidis : Platyrhinidae, IPlatyrhinoidis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyrhinoidis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117850;

    /// <inheritdoc />
    public virtual string GenusName => "Platyrhinoidis";

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
