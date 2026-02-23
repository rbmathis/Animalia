using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gnatholepis;

/// <summary>
/// Abstract class for Gnatholepis (genus).
/// NCBI TaxId: 151727
/// </summary>
public abstract class Gnatholepis : Gobiidae, IGnatholepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnatholepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 151727;

    /// <inheritdoc />
    public virtual string GenusName => "Gnatholepis";

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
