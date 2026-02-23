using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae.Platyrhina;

/// <summary>
/// Abstract class for Platyrhina (genus).
/// NCBI TaxId: 117849
/// </summary>
public abstract class Platyrhina : Platyrhinidae, IPlatyrhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyrhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117849;

    /// <inheritdoc />
    public virtual string GenusName => "Platyrhina";

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
