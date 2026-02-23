using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Pseudonigrita;

/// <summary>
/// Abstract class for Pseudonigrita (genus).
/// NCBI TaxId: 280461
/// </summary>
public abstract class Pseudonigrita : Ploceidae, IPseudonigrita
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudonigrita";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 280461;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudonigrita";

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
