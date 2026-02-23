using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Gnathophis;

/// <summary>
/// Abstract class for Gnathophis (genus).
/// NCBI TaxId: 267668
/// </summary>
public abstract class Gnathophis : Congridae, IGnathophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 267668;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathophis";

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
