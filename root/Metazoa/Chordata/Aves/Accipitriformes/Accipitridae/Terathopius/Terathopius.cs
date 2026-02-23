using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Terathopius;

/// <summary>
/// Abstract class for Terathopius (genus).
/// NCBI TaxId: 321103
/// </summary>
public abstract class Terathopius : Accipitridae, ITerathopius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Terathopius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321103;

    /// <inheritdoc />
    public virtual string GenusName => "Terathopius";

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
