using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Akletos;

/// <summary>
/// Abstract class for Akletos (genus).
/// NCBI TaxId: 2767392
/// </summary>
public abstract class Akletos : Thamnophilidae, IAkletos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Akletos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767392;

    /// <inheritdoc />
    public virtual string GenusName => "Akletos";

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
