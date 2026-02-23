using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Cepphus;

/// <summary>
/// Abstract class for Cepphus (genus).
/// NCBI TaxId: 28695
/// </summary>
public abstract class Cepphus : Alcidae, ICepphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cepphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28695;

    /// <inheritdoc />
    public virtual string GenusName => "Cepphus";

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
