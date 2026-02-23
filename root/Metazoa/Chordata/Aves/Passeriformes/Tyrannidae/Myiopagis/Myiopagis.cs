using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiopagis;

/// <summary>
/// Abstract class for Myiopagis (genus).
/// NCBI TaxId: 196042
/// </summary>
public abstract class Myiopagis : Tyrannidae, IMyiopagis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiopagis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196042;

    /// <inheritdoc />
    public virtual string GenusName => "Myiopagis";

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
