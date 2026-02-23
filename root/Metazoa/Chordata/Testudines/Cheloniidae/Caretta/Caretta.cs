using AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Caretta;

/// <summary>
/// Abstract class for Caretta (genus).
/// NCBI TaxId: 8466
/// </summary>
public abstract class Caretta : Cheloniidae, ICaretta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caretta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8466;

    /// <inheritdoc />
    public virtual string GenusName => "Caretta";

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
