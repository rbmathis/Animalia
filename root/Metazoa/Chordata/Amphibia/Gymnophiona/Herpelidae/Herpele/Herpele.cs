using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae.Herpele;

/// <summary>
/// Abstract class for Herpele (genus).
/// NCBI TaxId: 118253
/// </summary>
public abstract class Herpele : Herpelidae, IHerpele
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herpele";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118253;

    /// <inheritdoc />
    public virtual string GenusName => "Herpele";

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
