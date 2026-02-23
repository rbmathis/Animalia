using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Chloebia;

/// <summary>
/// Abstract class for Chloebia (genus).
/// NCBI TaxId: 187421
/// </summary>
public abstract class Chloebia : Passeridae, IChloebia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloebia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187421;

    /// <inheritdoc />
    public virtual string GenusName => "Chloebia";

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
