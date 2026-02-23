using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae.Rhodosoma;

/// <summary>
/// Abstract class for Rhodosoma (genus).
/// NCBI TaxId: 1256664
/// </summary>
public abstract class Rhodosoma : Corellidae, IRhodosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1256664;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodosoma";

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
