using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Distaplia;

/// <summary>
/// Abstract class for Distaplia (genus).
/// NCBI TaxId: 322838
/// </summary>
public abstract class Distaplia : Clavelinidae, IDistaplia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Distaplia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322838;

    /// <inheritdoc />
    public virtual string GenusName => "Distaplia";

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
