using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Parambassis;

/// <summary>
/// Abstract class for Parambassis (genus).
/// NCBI TaxId: 210631
/// </summary>
public abstract class Parambassis : Ambassidae, IParambassis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parambassis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210631;

    /// <inheritdoc />
    public virtual string GenusName => "Parambassis";

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
