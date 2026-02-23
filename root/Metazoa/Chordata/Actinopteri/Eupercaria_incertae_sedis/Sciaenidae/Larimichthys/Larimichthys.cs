using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Larimichthys;

/// <summary>
/// Abstract class for Larimichthys (genus).
/// NCBI TaxId: 215357
/// </summary>
public abstract class Larimichthys : Sciaenidae, ILarimichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Larimichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215357;

    /// <inheritdoc />
    public virtual string GenusName => "Larimichthys";

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
