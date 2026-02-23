using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Mascarenotus;

/// <summary>
/// Abstract class for Mascarenotus (genus).
/// NCBI TaxId: 2259023
/// </summary>
public abstract class Mascarenotus : Strigidae, IMascarenotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mascarenotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2259023;

    /// <inheritdoc />
    public virtual string GenusName => "Mascarenotus";

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
