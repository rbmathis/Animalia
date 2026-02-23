using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Pampusana;

/// <summary>
/// Abstract class for Pampusana (genus).
/// NCBI TaxId: 2953413
/// </summary>
public abstract class Pampusana : Columbidae, IPampusana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pampusana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2953413;

    /// <inheritdoc />
    public virtual string GenusName => "Pampusana";

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
