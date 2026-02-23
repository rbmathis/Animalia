using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Ceuthmochares;

/// <summary>
/// Abstract class for Ceuthmochares (genus).
/// NCBI TaxId: 1961833
/// </summary>
public abstract class Ceuthmochares : Cuculidae, ICeuthmochares
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceuthmochares";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1961833;

    /// <inheritdoc />
    public virtual string GenusName => "Ceuthmochares";

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
