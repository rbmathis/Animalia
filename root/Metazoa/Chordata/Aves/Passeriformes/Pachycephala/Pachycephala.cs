using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

/// <summary>
/// Abstract class for Pachycephala (genus).
/// NCBI TaxId: 46903
/// </summary>
public abstract class Pachycephala : Passeriformes, IPachycephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachycephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46903;

    /// <inheritdoc />
    public virtual string GenusName => "Pachycephala";

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
