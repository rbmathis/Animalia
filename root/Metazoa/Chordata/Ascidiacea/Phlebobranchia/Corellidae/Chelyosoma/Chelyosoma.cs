using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae.Chelyosoma;

/// <summary>
/// Abstract class for Chelyosoma (genus).
/// NCBI TaxId: 71176
/// </summary>
public abstract class Chelyosoma : Corellidae, IChelyosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelyosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71176;

    /// <inheritdoc />
    public virtual string GenusName => "Chelyosoma";

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
