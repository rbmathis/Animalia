using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chersina;

/// <summary>
/// Abstract class for Chersina (genus).
/// NCBI TaxId: 286000
/// </summary>
public abstract class Chersina : Testudinidae, IChersina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chersina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286000;

    /// <inheritdoc />
    public virtual string GenusName => "Chersina";

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
