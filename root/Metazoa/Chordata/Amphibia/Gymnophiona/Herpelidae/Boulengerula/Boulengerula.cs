using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae.Boulengerula;

/// <summary>
/// Abstract class for Boulengerula (genus).
/// NCBI TaxId: 102245
/// </summary>
public abstract class Boulengerula : Herpelidae, IBoulengerula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boulengerula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 102245;

    /// <inheritdoc />
    public virtual string GenusName => "Boulengerula";

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
